import { Meta, Story } from "@storybook/react/types-6-0";
import ArchiveListTable from "../components/ArchiveListTable";
import StoryRouter from 'storybook-react-router';

export default {
    title: "components/ArchiveListTable",
    decorators: [StoryRouter()],
    components: ArchiveListTable,
} as Meta;

const Template: Story = () => <ArchiveListTable />;

export const Default = Template.bind({});