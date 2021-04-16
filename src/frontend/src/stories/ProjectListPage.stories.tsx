import { Meta, Story } from "@storybook/react/types-6-0";
import ProjectListPage from "../pages/ProjectListPage";
import StoryRouter from 'storybook-react-router';

export default {
    title: "pages/ProjectListPage",
    decorators: [StoryRouter()],
    components: ProjectListPage,
} as Meta;

const Template: Story = () => <ProjectListPage />;

export const Default = Template.bind({});