import { Meta, Story } from "@storybook/react/types-6-0";
import ProjectListTable from "../components/ProjectListTable";
import StoryRouter from 'storybook-react-router';

export default {
    title: "components/ProjectListTable",
    decorators: [StoryRouter()],
    components: ProjectListTable,
} as Meta;

const Template: Story = () => <ProjectListTable />;

export const Default = Template.bind({});